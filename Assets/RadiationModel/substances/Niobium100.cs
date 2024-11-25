using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium100";
        public override double halfLife { get; } = 1.4d;
        public override double atomicWeight { get; } = 99.91434d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum100() }, { 1.0d, new BetaParticle(-1, 3201000.0) }, { 0.08900000000000001d, new GammaParticle(159500.0, 0.00777) }, { 0.0012d, new GammaParticle(327000.0, 0.00379) }, { 0.0013d, new GammaParticle(368600.0, 0.00336) }, { 0.0016d, new GammaParticle(400000.0, 0.0031) }, { 0.010700000000000001d, new GammaParticle(440900.0, 0.00281) }, { 0.001d, new GammaParticle(471000.0, 0.00263) }, { 0.002d, new GammaParticle(513200.0, 0.00242) }, { 0.091d, new GammaParticle(528263.0, 0.00235) }, { 0.457d, new GammaParticle(535666.0, 0.00231) }, { 0.0042d, new GammaParticle(543400.0, 0.00228) }, { 0.0029d, new GammaParticle(573500.0, 0.00216) }, { 0.0055000000000000005d, new GammaParticle(600500.0, 0.00206) }, { 0.014499999999999999d, new GammaParticle(622500.0, 0.00199) }, { 0.034d, new GammaParticle(768700.0, 0.00161) }, { 0.004d, new GammaParticle(856300.0, 0.00145) }, { 0.0019d, new GammaParticle(913200.0, 0.00136) }, { 0.025d, new GammaParticle(928300.0, 0.00134) }, { 0.026000000000000002d, new GammaParticle(969100.0, 0.00128) }, { 0.049d, new GammaParticle(1022500.0, 0.00121) }, { 0.033d, new GammaParticle(1063700.0, 0.00117) }, { 0.0049d, new GammaParticle(1071600.0, 0.00116) }, { 0.0031d, new GammaParticle(1125800.0, 0.0011) }, { 0.009000000000000001d, new GammaParticle(1257000.0, 0.00099) }, { 0.0014000000000000002d, new GammaParticle(1281800.0, 0.00097) }, { 0.001d, new GammaParticle(1362500.0, 0.00091) }, { 0.0007000000000000001d, new GammaParticle(1391000.0, 0.00089) }, { 0.001d, new GammaParticle(1397000.0, 0.00089) }, { 0.0006d, new GammaParticle(1432000.0, 0.00087) }, { 0.0027d, new GammaParticle(1441500.0, 0.00086) }, { 0.044000000000000004d, new GammaParticle(1501900.0, 0.00083) }, { 0.0068000000000000005d, new GammaParticle(1550500.0, 0.0008) }, { 0.0021d, new GammaParticle(1598700.0, 0.00078) }, { 0.0123d, new GammaParticle(1653900.0, 0.00075) }, { 0.0028000000000000004d, new GammaParticle(1665700.0, 0.00074) }, { 0.0033d, new GammaParticle(1871000.0, 0.00066) }, { 0.0039000000000000003d, new GammaParticle(1906600.0, 0.00065) }, { 0.0139d, new GammaParticle(2434600.0, 0.00051) }, { 0.0034000000000000002d, new GammaParticle(2526900.0, 0.00049) }, { 0.008100000000000001d, new GammaParticle(2534600.0, 0.00049) }, { 0.0008433675881916001d, new GammaParticle(2440.0, 0.50813) }, { 0.004138350985110402d, new GammaParticle(17374.0, 0.07136) }, { 0.007887080207948165d, new GammaParticle(17479.0, 0.07093) }, { 0.002069541278112159d, new GammaParticle(19681.0, 0.063) }, { 0.0023882506349414316d, new GammaParticle(19794.0, 0.06264) }, { 0.00031870935682927254d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    