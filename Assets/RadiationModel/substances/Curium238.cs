using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium238";
        public override double halfLife { get; } = 7920.0d;
        public override double atomicWeight { get; } = 238.05308d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0384d, new List<RadioactiveSubstance> { new AlphaParticle(7690047.4), new Plutonium234() } },
            { 0.00048d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    