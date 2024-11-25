using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium236";
        public override double halfLife { get; } = 4891323526061.76d;
        public override double atomicWeight { get; } = 236.04657d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.878d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium236() }, { 0.0012640000000000001d, new GammaParticle(45243.0, 0.0274) }, { 5.056e-06d, new GammaParticle(56600.0, 0.02191) }, { 8.026399999999999e-05d, new GammaParticle(103400.0, 0.01199) }, { 0.07268d, new GammaParticle(104237.0, 0.01189) }, { 0.316d, new GammaParticle(160308.0, 0.00773) }, { 3.16e-06d, new GammaParticle(538090.0, 0.0023) }, { 0.0002528d, new GammaParticle(642230.0, 0.00193) }, { 6.32e-05d, new GammaParticle(687590.0, 0.0018) }, { 1.1059966321984d, new GammaParticle(16678.0, 0.07434) }, { 0.20037870199224306d, new GammaParticle(94657.0, 0.0131) }, { 0.32075988793379706d, new GammaParticle(98439.0, 0.0126) }, { 0.11572228002828609d, new GammaParticle(111238.0, 0.01115) }, { 0.15529929979795995d, new GammaParticle(112645.0, 0.01101) }, { 0.039577019769673843d, new GammaParticle(114446.0, 0.01083) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium236() }, { 1.0d, new BetaParticle(-1, 239250.0) }, { 0.00018328d, new GammaParticle(44630.0, 0.02778) }, { 0.009164d, new GammaParticle(102820.0, 0.01206) }, { 0.042660000000000003d, new GammaParticle(158350.0, 0.00783) }, { 0.13419257360538d, new GammaParticle(17604.0, 0.07043) }, { 0.00237163550455121d, new GammaParticle(99533.0, 0.01246) }, { 0.003754369961296834d, new GammaParticle(103741.0, 0.01195) }, { 0.0013780101381974438d, new GammaParticle(117130.0, 0.01059) }, { 0.0018561796561519569d, new GammaParticle(118619.0, 0.01045) }, { 0.00047816951795451296d, new GammaParticle(120544.0, 0.01029) } } },
            { 0.0016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium232() }, { 1.0d, new AlphaParticle(6030002.09) } } },

        };
    }
}
    