﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PrestamoGJ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PrestamoGJ.Application.Core.Utils
{
    public class JwtConfigurator
    {
        public static string GetToken(Usuario userInfo, IConfiguration configuration)
        {
            string SecretKey = configuration["Jwt:SecretKey"];
            string Issuer = configuration["Jwt:Issuer"];
            string Audience = configuration["Jwt:Audience"];


            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub, userInfo.nombre),
                new Claim("idUsuario",userInfo.idtrabajador.ToString()),
                new Claim("acceso",userInfo.acceso.ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static int GetTokenIdUsuario(ClaimsIdentity identity)
        {
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                foreach (var claim in claims)
                {
                    if (claim.Type == "idUsuario")
                    {
                        return int.Parse(claim.Value);
                    }
                }
            }
            return 0;
        }
    }
}
