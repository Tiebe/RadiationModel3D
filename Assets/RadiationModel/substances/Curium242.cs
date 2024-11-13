
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium242";
        public override double halfLife { get; } = 14065920.0d;
        public override double atomicWeight { get; } = 242.05883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium238() } },

            { 6.2e-08d, new List<RadioactiveSubstance> {  } },

            { 1.1e-16d, new List<RadioactiveSubstance> { new Silicon34(), new Lead208() } },

        };
    }
}
    
    