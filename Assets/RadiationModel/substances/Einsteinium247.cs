
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium247";
        public override double halfLife { get; } = 273.0d;
        public override double atomicWeight { get; } = 247.07362d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(), new Californium247() } },

            { 0.07d, new List<RadioactiveSubstance> { new AlphaParticle(), new Berkelium243() } },

        };
    }
}
    
    