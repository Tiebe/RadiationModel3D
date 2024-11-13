
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine30 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine30";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 30.00502d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Sulfur29() } },

        };
    }
}
    
    