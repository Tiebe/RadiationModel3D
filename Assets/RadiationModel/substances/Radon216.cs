using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon216 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon216";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 216.00027d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9217447.399999999), new Polonium212() } },

        };
    }
}
    
    