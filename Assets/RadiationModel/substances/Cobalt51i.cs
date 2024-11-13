
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt51i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt51i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 50.97781d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Iron50() } },

        };
    }
}
    
    