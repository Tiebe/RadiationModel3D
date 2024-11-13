
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium243";
        public override double halfLife { get; } = 111.0d;
        public override double atomicWeight { get; } = 243.06421d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Plutonium243() } },

        };
    }
}
    
    