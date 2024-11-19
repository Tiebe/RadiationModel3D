using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium239";
        public override double halfLife { get; } = 42840.0d;
        public override double atomicWeight { get; } = 239.05302d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9998999999999999d, new List<RadioactiveSubstance> { new Plutonium239() } },
            { 0.0001d, new List<RadioactiveSubstance> { new AlphaParticle(6944402.09), new Neptunium235() } },

        };
    }
}
    
    