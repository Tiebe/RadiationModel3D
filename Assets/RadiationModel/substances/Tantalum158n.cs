
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum158n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 157.96961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.986d, new List<RadioactiveSubstance> { new GammaParticle(), new Tantalum158() } },

            { 0.013999999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lutetium154() } },

        };
    }
}
    
    