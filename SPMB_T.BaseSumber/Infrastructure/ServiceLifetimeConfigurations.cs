using SPMB_T.__Domain.Entities._Statics;
using SPMB_T.__Domain.Entities.Administrations;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using SPMB_T._DataAccess.Repositories.Implementations;
using SPMB_T._DataAccess.Repositories.Interfaces;
using SPMB_T._DataAccess.Services.Banking;
using SPMB_T._DataAccess.Services.Cart.Session;

namespace SPMB_T.BaseSumber.Infrastructure
{
    public static class ServiceLifetimeConfigurations
    {
        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<UserServices, UserServices>();
            services.AddTransient<_AppLogIRepository<AppLog, int>, _AppLogRepository>();

            services.AddTransient<_IUnitOfWork, _UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddSystemAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(opt =>
            {
                // Sistem (SI)
                //

                // Jadual (JD)
                opt.AddPolicy(Modules.kodJAgama, policy => policy.RequireClaim(Modules.kodJAgama));
                opt.AddPolicy(Modules.kodJAgama + "C", policy => policy.RequireClaim(Modules.kodJAgama + "C"));
                opt.AddPolicy(Modules.kodJAgama + "E", policy => policy.RequireClaim(Modules.kodJAgama + "E"));
                opt.AddPolicy(Modules.kodJAgama + "D", policy => policy.RequireClaim(Modules.kodJAgama + "D"));
                opt.AddPolicy(Modules.kodJAgama + "R", policy => policy.RequireClaim(Modules.kodJAgama + "R"));

                opt.AddPolicy(Modules.kodJBahagian, policy => policy.RequireClaim(Modules.kodJBahagian));
                opt.AddPolicy(Modules.kodJBahagian + "C", policy => policy.RequireClaim(Modules.kodJBahagian + "C"));
                opt.AddPolicy(Modules.kodJBahagian + "E", policy => policy.RequireClaim(Modules.kodJBahagian + "E"));
                opt.AddPolicy(Modules.kodJBahagian + "D", policy => policy.RequireClaim(Modules.kodJBahagian + "D"));
                opt.AddPolicy(Modules.kodJBahagian + "R", policy => policy.RequireClaim(Modules.kodJBahagian + "R"));

                opt.AddPolicy(Modules.kodJBangsa, policy => policy.RequireClaim(Modules.kodJBangsa));
                opt.AddPolicy(Modules.kodJBangsa + "C", policy => policy.RequireClaim(Modules.kodJBangsa + "C"));
                opt.AddPolicy(Modules.kodJBangsa + "E", policy => policy.RequireClaim(Modules.kodJBangsa + "E"));
                opt.AddPolicy(Modules.kodJBangsa + "D", policy => policy.RequireClaim(Modules.kodJBangsa + "D"));
                opt.AddPolicy(Modules.kodJBangsa + "R", policy => policy.RequireClaim(Modules.kodJBangsa + "R"));

                opt.AddPolicy(Modules.kodJBank, policy => policy.RequireClaim(Modules.kodJBank));
                opt.AddPolicy(Modules.kodJBank + "C", policy => policy.RequireClaim(Modules.kodJBank + "C"));
                opt.AddPolicy(Modules.kodJBank + "E", policy => policy.RequireClaim(Modules.kodJBank + "E"));
                opt.AddPolicy(Modules.kodJBank + "D", policy => policy.RequireClaim(Modules.kodJBank + "D"));
                opt.AddPolicy(Modules.kodJBank + "R", policy => policy.RequireClaim(Modules.kodJBank + "R"));

                opt.AddPolicy(Modules.kodJCaraBayar, policy => policy.RequireClaim(Modules.kodJCaraBayar));
                opt.AddPolicy(Modules.kodJCaraBayar + "C", policy => policy.RequireClaim(Modules.kodJCaraBayar + "C"));
                opt.AddPolicy(Modules.kodJCaraBayar + "E", policy => policy.RequireClaim(Modules.kodJCaraBayar + "E"));
                opt.AddPolicy(Modules.kodJCaraBayar + "D", policy => policy.RequireClaim(Modules.kodJCaraBayar + "D"));
                opt.AddPolicy(Modules.kodJCaraBayar + "R", policy => policy.RequireClaim(Modules.kodJCaraBayar + "R"));

                opt.AddPolicy(Modules.kodJCawangan, policy => policy.RequireClaim(Modules.kodJCawangan));
                opt.AddPolicy(Modules.kodJCawangan + "C", policy => policy.RequireClaim(Modules.kodJCawangan + "C"));
                opt.AddPolicy(Modules.kodJCawangan + "E", policy => policy.RequireClaim(Modules.kodJCawangan + "E"));
                opt.AddPolicy(Modules.kodJCawangan + "D", policy => policy.RequireClaim(Modules.kodJCawangan + "D"));
                opt.AddPolicy(Modules.kodJCawangan + "R", policy => policy.RequireClaim(Modules.kodJCawangan + "R"));

                opt.AddPolicy(Modules.kodJNegeri, policy => policy.RequireClaim(Modules.kodJNegeri));
                opt.AddPolicy(Modules.kodJNegeri + "C", policy => policy.RequireClaim(Modules.kodJNegeri + "C"));
                opt.AddPolicy(Modules.kodJNegeri + "E", policy => policy.RequireClaim(Modules.kodJNegeri + "E"));
                opt.AddPolicy(Modules.kodJNegeri + "D", policy => policy.RequireClaim(Modules.kodJNegeri + "D"));
                opt.AddPolicy(Modules.kodJNegeri + "R", policy => policy.RequireClaim(Modules.kodJNegeri + "R"));

                opt.AddPolicy(Modules.kodJPTJ, policy => policy.RequireClaim(Modules.kodJPTJ));
                opt.AddPolicy(Modules.kodJPTJ + "C", policy => policy.RequireClaim(Modules.kodJPTJ + "C"));
                opt.AddPolicy(Modules.kodJPTJ + "E", policy => policy.RequireClaim(Modules.kodJPTJ + "E"));
                opt.AddPolicy(Modules.kodJPTJ + "D", policy => policy.RequireClaim(Modules.kodJPTJ + "D"));
                opt.AddPolicy(Modules.kodJPTJ + "R", policy => policy.RequireClaim(Modules.kodJPTJ + "R"));

                opt.AddPolicy(Modules.kodJKategoriPCB, policy => policy.RequireClaim(Modules.kodJKategoriPCB));
                opt.AddPolicy(Modules.kodJKategoriPCB + "C", policy => policy.RequireClaim(Modules.kodJKategoriPCB + "C"));
                opt.AddPolicy(Modules.kodJKategoriPCB + "E", policy => policy.RequireClaim(Modules.kodJKategoriPCB + "E"));
                opt.AddPolicy(Modules.kodJKategoriPCB + "D", policy => policy.RequireClaim(Modules.kodJKategoriPCB + "D"));
                opt.AddPolicy(Modules.kodJKategoriPCB + "R", policy => policy.RequireClaim(Modules.kodJKategoriPCB + "R"));

                opt.AddPolicy(Modules.kodJGredGaji, policy => policy.RequireClaim(Modules.kodJGredGaji));
                opt.AddPolicy(Modules.kodJGredGaji + "C", policy => policy.RequireClaim(Modules.kodJGredGaji + "C"));
                opt.AddPolicy(Modules.kodJGredGaji + "E", policy => policy.RequireClaim(Modules.kodJGredGaji + "E"));
                opt.AddPolicy(Modules.kodJGredGaji + "D", policy => policy.RequireClaim(Modules.kodJGredGaji + "D"));
                opt.AddPolicy(Modules.kodJGredGaji + "R", policy => policy.RequireClaim(Modules.kodJGredGaji + "R"));

                opt.AddPolicy(Modules.kodJTanggaGaji, policy => policy.RequireClaim(Modules.kodJTanggaGaji));
                opt.AddPolicy(Modules.kodJTanggaGaji + "C", policy => policy.RequireClaim(Modules.kodJTanggaGaji + "C"));
                opt.AddPolicy(Modules.kodJTanggaGaji + "E", policy => policy.RequireClaim(Modules.kodJTanggaGaji + "E"));
                opt.AddPolicy(Modules.kodJTanggaGaji + "D", policy => policy.RequireClaim(Modules.kodJTanggaGaji + "D"));
                opt.AddPolicy(Modules.kodJTanggaGaji + "R", policy => policy.RequireClaim(Modules.kodJTanggaGaji + "R"));

                opt.AddPolicy(Modules.kodJElaunPotongan, policy => policy.RequireClaim(Modules.kodJElaunPotongan));
                opt.AddPolicy(Modules.kodJElaunPotongan + "C", policy => policy.RequireClaim(Modules.kodJElaunPotongan + "C"));
                opt.AddPolicy(Modules.kodJElaunPotongan + "E", policy => policy.RequireClaim(Modules.kodJElaunPotongan + "E"));
                opt.AddPolicy(Modules.kodJElaunPotongan + "D", policy => policy.RequireClaim(Modules.kodJElaunPotongan + "D"));
                opt.AddPolicy(Modules.kodJElaunPotongan + "R", policy => policy.RequireClaim(Modules.kodJElaunPotongan + "R"));

                opt.AddPolicy(Modules.kodJGredTanggaGaji, policy => policy.RequireClaim(Modules.kodJGredTanggaGaji));
                opt.AddPolicy(Modules.kodJGredTanggaGaji + "C", policy => policy.RequireClaim(Modules.kodJGredTanggaGaji + "C"));
                opt.AddPolicy(Modules.kodJGredTanggaGaji + "E", policy => policy.RequireClaim(Modules.kodJGredTanggaGaji + "E"));
                opt.AddPolicy(Modules.kodJGredTanggaGaji + "D", policy => policy.RequireClaim(Modules.kodJGredTanggaGaji + "D"));
                opt.AddPolicy(Modules.kodJGredTanggaGaji + "R", policy => policy.RequireClaim(Modules.kodJGredTanggaGaji + "R"));
                //

                // Daftar (DF)
                opt.AddPolicy(Modules.kodDDaftarAwam, policy => policy.RequireClaim(Modules.kodDDaftarAwam));
                opt.AddPolicy(Modules.kodDDaftarAwam + "C", policy => policy.RequireClaim(Modules.kodDDaftarAwam + "C"));
                opt.AddPolicy(Modules.kodDDaftarAwam + "E", policy => policy.RequireClaim(Modules.kodDDaftarAwam + "E"));
                opt.AddPolicy(Modules.kodDDaftarAwam + "D", policy => policy.RequireClaim(Modules.kodDDaftarAwam + "D"));
                opt.AddPolicy(Modules.kodDDaftarAwam + "R", policy => policy.RequireClaim(Modules.kodDDaftarAwam + "R"));

                opt.AddPolicy(Modules.kodDKonfigKelulusan, policy => policy.RequireClaim(Modules.kodDKonfigKelulusan));
                opt.AddPolicy(Modules.kodDKonfigKelulusan + "C", policy => policy.RequireClaim(Modules.kodDKonfigKelulusan + "C"));
                opt.AddPolicy(Modules.kodDKonfigKelulusan + "E", policy => policy.RequireClaim(Modules.kodDKonfigKelulusan + "E"));
                opt.AddPolicy(Modules.kodDKonfigKelulusan + "D", policy => policy.RequireClaim(Modules.kodDKonfigKelulusan + "D"));
                opt.AddPolicy(Modules.kodDKonfigKelulusan + "R", policy => policy.RequireClaim(Modules.kodDKonfigKelulusan + "R"));

                opt.AddPolicy(Modules.kodDPekerja, policy => policy.RequireClaim(Modules.kodDPekerja));
                opt.AddPolicy(Modules.kodDPekerja + "C", policy => policy.RequireClaim(Modules.kodDPekerja + "C"));
                opt.AddPolicy(Modules.kodDPekerja + "E", policy => policy.RequireClaim(Modules.kodDPekerja + "E"));
                opt.AddPolicy(Modules.kodDPekerja + "D", policy => policy.RequireClaim(Modules.kodDPekerja + "D"));
                opt.AddPolicy(Modules.kodDPekerja + "R", policy => policy.RequireClaim(Modules.kodDPekerja + "R"));

                opt.AddPolicy(Modules.kodDPenerimaCekGaji, policy => policy.RequireClaim(Modules.kodDPenerimaCekGaji));
                opt.AddPolicy(Modules.kodDPenerimaCekGaji + "C", policy => policy.RequireClaim(Modules.kodDPenerimaCekGaji + "C"));
                opt.AddPolicy(Modules.kodDPenerimaCekGaji + "E", policy => policy.RequireClaim(Modules.kodDPenerimaCekGaji + "E"));
                opt.AddPolicy(Modules.kodDPenerimaCekGaji + "D", policy => policy.RequireClaim(Modules.kodDPenerimaCekGaji + "D"));
                opt.AddPolicy(Modules.kodDPenerimaCekGaji + "R", policy => policy.RequireClaim(Modules.kodDPenerimaCekGaji + "R"));
                //

                // Sumber (SU)

                //

                // Pemprosesan (PP)

                //


            }
            );
            return services;
        }
    }
}
