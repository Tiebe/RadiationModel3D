using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium235";
        public override double halfLife { get; } = 420.0d;
        public override double atomicWeight { get; } = 235.05154d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.04d, new List<RadioactiveSubstance> { new AlphaParticle(8296047.399999999), new Plutonium231() } },

        };
    }
}
    
    