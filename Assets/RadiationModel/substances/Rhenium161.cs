
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium161";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 160.97763d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Tungsten160() } },

        };
    }
}
    
    