using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium222";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 222.03357d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11215047.4), new Protactinium218() } },

        };
    }
}
    
    