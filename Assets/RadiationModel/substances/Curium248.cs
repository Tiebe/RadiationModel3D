
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium248";
        public override double halfLife { get; } = 10981819296000.0d;
        public override double atomicWeight { get; } = 248.07235d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9161d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium244() } },

            { 0.0839d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    