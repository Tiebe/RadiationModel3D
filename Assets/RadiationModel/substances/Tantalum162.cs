using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum162 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum162";
        public override double halfLife { get; } = 3.57d;
        public override double atomicWeight { get; } = 161.95729d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99926d, new List<RadioactiveSubstance> { new BetaParticle(1, 9388000.0), new Hafnium162() } },
            { 0.00074d, new List<RadioactiveSubstance> { new AlphaParticle(6029002.09), new Lutetium158() } },

        };
    }
}
    
    