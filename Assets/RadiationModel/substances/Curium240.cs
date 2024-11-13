
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium240";
        public override double halfLife { get; } = 2626560.0d;
        public override double atomicWeight { get; } = 240.05553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Plutonium236() } },

            { 3.9e-08d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    