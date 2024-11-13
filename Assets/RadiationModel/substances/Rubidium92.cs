
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium92";
        public override double halfLife { get; } = 4.48d;
        public override double atomicWeight { get; } = 91.91973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium92() } },

        };
    }
}
    
    