
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium258m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium258m";
        public override double halfLife { get; } = 3420.0d;
        public override double atomicWeight { get; } = 258.09843d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.85d, new List<RadioactiveSubstance> { new Fermium258() } },

            { 0.15d, new List<RadioactiveSubstance> {  } },

            { 0.012d, new List<RadioactiveSubstance> { new AlphaParticle(), new Einsteinium254() } },

        };
    }
}
    
    