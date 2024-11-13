
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium164";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 163.97808d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.96d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tungsten160() } },

        };
    }
}
    
    