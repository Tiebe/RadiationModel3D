using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium242";
        public override double halfLife { get; } = 11770733388522.816d;
        public override double atomicWeight { get; } = 242.05874d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium238() }, { 1.0d, new AlphaParticle(6006202.09) }, { 0.00038399999999999996d, new GammaParticle(44915.0, 0.0276) }, { 0.00025299999999999997d, new GammaParticle(103500.0, 0.01198) }, { 2.2e-06d, new GammaParticle(159018.0, 0.0078) }, { 0.08648762234059999d, new GammaParticle(16678.0, 0.07434) }, { 1.3211871292014275e-07d, new GammaParticle(94657.0, 0.0131) }, { 2.1149145657138268e-07d, new GammaParticle(98439.0, 0.0126) }, { 7.630091692136704e-08d, new GammaParticle(111238.0, 0.01115) }, { 1.0239583050847457e-07d, new GammaParticle(112645.0, 0.01101) }, { 2.6094913587107525e-08d, new GammaParticle(114446.0, 0.01083) } } },
            { 5.5299999999999996e-06d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    