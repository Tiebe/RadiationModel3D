
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium258";
        public override double halfLife { get; } = 0.0125d;
        public override double atomicWeight { get; } = 258.10343d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.951d, new List<RadioactiveSubstance> {  } },

            { 0.049d, new List<RadioactiveSubstance> { new AlphaParticle(), new Nobelium254() } },

        };
    }
}
    
    