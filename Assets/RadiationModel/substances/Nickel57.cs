using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel57 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel57";
        public override double halfLife { get; } = 128160.0d;
        public override double atomicWeight { get; } = 56.93979d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron57() }, { 1.0d, new BetaParticle(1, 2049010.0) }, { 0.16666799999999998d, new GammaParticle(127164.0, 0.00975) }, { 0.000227126d, new GammaParticle(161860.0, 0.00766) }, { 1.9608e-05d, new GammaParticle(304100.0, 0.00408) }, { 0.0006699399999999999d, new GammaParticle(379940.0, 0.00326) }, { 3.6765e-05d, new GammaParticle(541900.0, 0.00229) }, { 0.000491017d, new GammaParticle(673440.0, 0.00184) }, { 8.987e-06d, new GammaParticle(696000.0, 0.00178) }, { 5.3921999999999996e-05d, new GammaParticle(755300.0, 0.00164) }, { 0.00061275d, new GammaParticle(906980.0, 0.00137) }, { 0.0013398799999999999d, new GammaParticle(1046680.0, 0.00118) }, { 0.0006290900000000001d, new GammaParticle(1224000.0, 0.00101) }, { 9.6406e-05d, new GammaParticle(1279990.0, 0.00097) }, { 1.9608e-05d, new GammaParticle(1350520.0, 0.00092) }, { 0.8170000000000001d, new GammaParticle(1377630.0, 0.0009) }, { 3.9216e-05d, new GammaParticle(1603280.0, 0.00077) }, { 0.00052288d, new GammaParticle(1730440.0, 0.00072) }, { 0.05751680000000001d, new GammaParticle(1757550.0, 0.00071) }, { 0.00027778d, new GammaParticle(1897420.0, 0.00065) }, { 0.12255d, new GammaParticle(1919520.0, 0.00065) }, { 0.00028595d, new GammaParticle(2133040.0, 0.00058) }, { 0.00019853099999999997d, new GammaParticle(2730910.0, 0.00045) }, { 0.0009804d, new GammaParticle(2804200.0, 0.00044) }, { 0.000111112d, new GammaParticle(3177280.0, 0.00039) }, { 0.87168d, new GammaParticle(511000.0, 0.00243) }, { 0.005536161435001057d, new GammaParticle(800.0, 1.5498) }, { 0.058198471037685814d, new GammaParticle(6915.0, 0.1793) }, { 0.1137577619970403d, new GammaParticle(6930.0, 0.17891) }, { 0.023592395172364423d, new GammaParticle(7677.0, 0.1615) }, { 0.023592395172364423d, new GammaParticle(7677.0, 0.1615) } } },

        };
    }
}
    