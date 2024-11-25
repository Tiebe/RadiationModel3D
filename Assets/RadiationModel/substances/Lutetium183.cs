using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium183";
        public override double halfLife { get; } = 58.0d;
        public override double atomicWeight { get; } = 182.95736d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium183() }, { 1.0d, new BetaParticle(-1, 1780000.0) }, { 0.045d, new GammaParticle(68600.0, 0.01807) }, { 0.025d, new GammaParticle(99400.0, 0.01247) }, { 0.01d, new GammaParticle(137300.0, 0.00903) }, { 0.0125d, new GammaParticle(148700.0, 0.00834) }, { 0.075d, new GammaParticle(168200.0, 0.00737) }, { 0.025d, new GammaParticle(205600.0, 0.00603) }, { 0.015d, new GammaParticle(220100.0, 0.00563) }, { 0.05d, new GammaParticle(248700.0, 0.00499) }, { 0.015d, new GammaParticle(316000.0, 0.00392) }, { 0.02d, new GammaParticle(449300.0, 0.00276) }, { 0.03d, new GammaParticle(957300.0, 0.0013) }, { 0.165d, new GammaParticle(1056700.0, 0.00117) }, { 0.03d, new GammaParticle(1087700.0, 0.00114) }, { 0.25d, new GammaParticle(1125300.0, 0.0011) }, { 0.015d, new GammaParticle(1187000.0, 0.00104) }, { 0.0125d, new GammaParticle(1436500.0, 0.00086) }, { 0.015d, new GammaParticle(1536500.0, 0.00081) }, { 0.0225d, new GammaParticle(1596700.0, 0.00078) }, { 0.15037943518d, new GammaParticle(9114.0, 0.13604) }, { 0.14809260698583146d, new GammaParticle(54608.0, 0.0227) }, { 0.25917502097625383d, new GammaParticle(55786.0, 0.02222) }, { 0.08550370089811736d, new GammaParticle(63333.0, 0.01958) }, { 0.10833318903791468d, new GammaParticle(64057.0, 0.01936) }, { 0.022829488139797335d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    