﻿using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class OtpAuthenticatorConfiguration
{
    public void Configure(EntityTypeBuilder<OtpAuthenticator> builder)
    {
        builder.ToTable("OtpAuthenticators").HasKey(oa => oa.Id);

        builder.Property(oa => oa.Id).HasColumnName("Id").IsRequired();
        builder.Property(oa => oa.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(oa => oa.SecretKey).HasColumnName("SecretKey").IsRequired();
        builder.Property(oa => oa.IsVerified).HasColumnName("IsVerified").IsRequired();
        builder.Property(oa => oa.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oa => oa.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oa => oa.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        builder.HasOne(oa => oa.User);
    }
}
