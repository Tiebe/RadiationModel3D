using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium244";
        public override double halfLife { get; } = 571496400.72d;
        public override double atomicWeight { get; } = 244.06275d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6921547.4), new Plutonium240() } },
            { 1.37e-06d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    