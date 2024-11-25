using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium235";
        public override double halfLife { get; } = 1518.0d;
        public override double atomicWeight { get; } = 235.04528d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999720000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium235() }, { 1.0d, new BetaParticle(1, 631599.99999) }, { 0.0023d, new GammaParticle(34200.0, 0.03625) }, { 0.024d, new GammaParticle(49100.0, 0.02525) }, { 4.7999999999999994e-05d, new GammaParticle(722200.0, 0.00172) }, { 0.00012d, new GammaParticle(739800.0, 0.00168) }, { 0.0009d, new GammaParticle(745100.0, 0.00166) }, { 0.0048d, new GammaParticle(756400.0, 0.00164) }, { 0.00037d, new GammaParticle(779600.0, 0.00159) }, { 7.000000000000001e-05d, new GammaParticle(785000.0, 0.00158) }, { 1.1999999999999999e-05d, new GammaParticle(819000.0, 0.00151) }, { 0.00010999999999999999d, new GammaParticle(858000.0, 0.00145) }, { 0.00017999999999999998d, new GammaParticle(902600.0, 0.00137) }, { 0.0016d, new GammaParticle(910100.0, 0.00136) }, { 0.00010999999999999999d, new GammaParticle(936700.0, 0.00132) }, { 0.00114d, new GammaParticle(940700.0, 0.00132) }, { 0.00114d, new GammaParticle(944700.0, 0.00131) }, { 0.53565058075977d, new GammaParticle(17136.0, 0.07235) }, { 0.2151192752172693d, new GammaParticle(97078.0, 0.01277) }, { 0.34243756004022496d, new GammaParticle(101068.0, 0.01227) }, { 0.12486949956287631d, new GammaParticle(114160.0, 0.01086) }, { 0.16782460741250577d, new GammaParticle(115608.0, 0.01072) }, { 0.042955107849629456d, new GammaParticle(117470.0, 0.01055) } } },
            { 2.8e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium231() }, { 1.0d, new AlphaParticle(6973002.09) } } },

        };
    }
}
    