
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium260";
        public override double halfLife { get; } = 0.00495d;
        public override double atomicWeight { get; } = 260.11438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.71d, new List<RadioactiveSubstance> {  } },

            { 0.29d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rutherfordium256() } },

        };
    }
}
    
    