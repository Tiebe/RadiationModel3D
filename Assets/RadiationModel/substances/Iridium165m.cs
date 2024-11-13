
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium165m";
        public override double halfLife { get; } = 0.00032d;
        public override double atomicWeight { get; } = 164.98774d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.88d, new List<RadioactiveSubstance> { new ProtonParticle(), new Osmium164() } },

            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium161() } },

        };
    }
}
    
    