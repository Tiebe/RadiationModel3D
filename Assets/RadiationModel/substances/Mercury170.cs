
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury170 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury170";
        public override double halfLife { get; } = 0.00031d;
        public override double atomicWeight { get; } = 170.00582d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum166() } },

        };
    }
}
    
    