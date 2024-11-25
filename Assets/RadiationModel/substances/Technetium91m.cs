using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium91m";
        public override double halfLife { get; } = 198.0d;
        public override double atomicWeight { get; } = 90.91857d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium91() }, { 1.0d, new BetaParticle(1, 5395300.0) }, { 0.00027560000000000003d, new GammaParticle(205600.0, 0.00603) }, { 0.50668d, new GammaParticle(502900.0, 0.00247) }, { 0.014469000000000001d, new GammaParticle(606700.0, 0.00204) }, { 0.0371d, new GammaParticle(927600.0, 0.00134) }, { 0.024963000000000003d, new GammaParticle(1328400.0, 0.00093) }, { 0.024698d, new GammaParticle(1362000.0, 0.00091) }, { 0.019557d, new GammaParticle(1430400.0, 0.00087) }, { 0.024432999999999996d, new GammaParticle(1534400.0, 0.00081) }, { 0.005194d, new GammaParticle(2037400.0, 0.00061) }, { 1.8980000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.0015012900796830253d, new GammaParticle(2440.0, 0.50813) }, { 0.0075492518940456586d, new GammaParticle(17374.0, 0.07136) }, { 0.014387748988080158d, new GammaParticle(17479.0, 0.07093) }, { 0.003775293219402242d, new GammaParticle(19681.0, 0.063) }, { 0.004356688375190187d, new GammaParticle(19794.0, 0.06264) }, { 0.0005813951557879453d, new GammaParticle(19963.0, 0.06211) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium91() } } },

        };
    }
}
    