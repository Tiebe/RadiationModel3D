using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium223";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 223.03291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10677002.09), new Protactinium219() } },

        };
    }
}
    
    