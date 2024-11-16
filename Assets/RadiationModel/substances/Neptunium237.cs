using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium237";
        public override double halfLife { get; } = 67658105088000.0d;
        public override double atomicWeight { get; } = 237.04817d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5979202.09), new Protactinium233() } },
            { 2e-12d, new List<RadioactiveSubstance> {  } },
            { 4e-14d, new List<RadioactiveSubstance> { new Magnesium30(), new Thallium207() } },

        };
    }
}
    
    