
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium223";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 223.04584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Neptunium219() } },

        };
    }
}
    
    