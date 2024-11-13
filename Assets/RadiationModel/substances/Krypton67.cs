
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton67 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton67";
        public override double halfLife { get; } = 0.0074d;
        public override double atomicWeight { get; } = 66.98331d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.37d, new List<RadioactiveSubstance> { new ProtonParticle(), new Selenium65() } },

        };
    }
}
    
    