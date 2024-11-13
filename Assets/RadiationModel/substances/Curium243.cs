
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium243";
        public override double halfLife { get; } = 918307303.2d;
        public override double atomicWeight { get; } = 243.06139d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium239() } },

            { 0.0029d, new List<RadioactiveSubstance> { new Americium243() } },

            { 5.3000000000000004e-11d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    