
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium13 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium13";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 13.06117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new NeutronParticle(), new Lithium11() } },

        };
    }
}
    
    