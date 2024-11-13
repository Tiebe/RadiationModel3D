
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium219m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium219m";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 219.0101d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radon215() } },

        };
    }
}
    
    