using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen16p : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen16p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 16.00884d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new List<RadioactiveSubstance> { new ProtonParticle(), new Nitrogen15() } },
            { 0.22d, new List<RadioactiveSubstance> { new AlphaParticle(6828602.09), new Carbon12() } },
            { 0.0028000000000000004d, new List<RadioactiveSubstance> { new GammaParticle((12968602.1, 0.0001)), new Oxygen16() } },

        };
    }
}
    
    