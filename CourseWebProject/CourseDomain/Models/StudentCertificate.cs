﻿namespace CourseDomain;

public  class StudentCertificate
{
    public int UserId { get; set; }

    public int CertificateId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual Certificate Certificate { get; set; } = null!;
}
