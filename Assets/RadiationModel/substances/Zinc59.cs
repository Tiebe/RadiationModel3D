using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc59 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc59";
        public override double halfLife { get; } = 0.1786d;
        public override double atomicWeight { get; } = 58.94931d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel59() }, { 1.0d, new BetaParticle(1, 6970550.0) }, { 0.002d, new GammaParticle(423000.0, 0.00293) }, { 0.048d, new GammaParticle(491400.0, 0.00252) }, { 0.011000000000000001d, new GammaParticle(914200.0, 0.00136) }, { 2.000838d, new GammaParticle(511000.0, 0.00243) }, { 1.5804939407213998e-05d, new GammaParticle(952.0, 1.30236) }, { 0.00015031945919145387d, new GammaParticle(8028.0, 0.15444) }, { 0.0002928491314853962d, new GammaParticle(8048.0, 0.15406) }, { 6.164475096314984e-05d, new GammaParticle(8940.0, 0.13868) }, { 6.164475096314984e-05d, new GammaParticle(8940.0, 0.13868) } } },
            { 0.001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel58() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    