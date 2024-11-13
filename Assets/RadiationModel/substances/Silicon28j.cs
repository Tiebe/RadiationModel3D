
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon28j : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon28j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 27.99327d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(), new Magnesium24() } },

            { 0.1d, new List<RadioactiveSubstance> { new ProtonParticle(), new Aluminum27() } },

        };
    }
}
    
    