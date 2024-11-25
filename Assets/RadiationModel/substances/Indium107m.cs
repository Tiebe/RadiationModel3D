using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium107m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium107m";
        public override double halfLife { get; } = 50.4d;
        public override double atomicWeight { get; } = 106.91102d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium107() }, { 0.943d, new GammaParticle(678400.0, 0.00183) }, { 0.0052153090272000005d, new GammaParticle(3571.0, 0.3472) }, { 0.016954385629256483d, new GammaParticle(24001.0, 0.05166) }, { 0.03180935390104406d, new GammaParticle(24209.0, 0.05121) }, { 0.008924993672016351d, new GammaParticle(27367.0, 0.0453) }, { 0.010620742469699457d, new GammaParticle(27581.0, 0.04495) }, { 0.0016957487976831068d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    