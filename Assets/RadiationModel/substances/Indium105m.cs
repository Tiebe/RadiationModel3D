using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium105m";
        public override double halfLife { get; } = 48.0d;
        public override double atomicWeight { get; } = 104.91523d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium105() }, { 0.943d, new GammaParticle(674100.0, 0.00184) }, { 0.00359395488d, new GammaParticle(3571.0, 0.3472) }, { 0.01161359137139176d, new GammaParticle(24001.0, 0.05166) }, { 0.021789102010115875d, new GammaParticle(24209.0, 0.05121) }, { 0.0061135349735229935d, new GammaParticle(27367.0, 0.0453) }, { 0.007275106618492363d, new GammaParticle(27581.0, 0.04495) }, { 0.0011615716449693688d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    