using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium200";
        public override double halfLife { get; } = 0.0475d;
        public override double atomicWeight { get; } = 200.00658d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8635047.4), new Astatine196() } },

        };
    }
}
    
    