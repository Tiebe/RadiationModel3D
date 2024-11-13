
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium251";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 251.08894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.83d, new List<RadioactiveSubstance> { new AlphaParticle(), new Fermium247() } },

            { 0.003d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    