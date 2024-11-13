
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium251";
        public override double halfLife { get; } = 118800.0d;
        public override double atomicWeight { get; } = 251.07999d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.995d, new List<RadioactiveSubstance> { new Californium251() } },

            { 0.005d, new List<RadioactiveSubstance> { new AlphaParticle(), new Berkelium247() } },

        };
    }
}
    
    