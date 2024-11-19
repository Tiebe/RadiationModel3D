using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium231";
        public override double halfLife { get; } = 1030334482800.0d;
        public override double atomicWeight { get; } = 231.03588d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6171802.09), new Actinium227() } },
            { 3e-12d, new List<RadioactiveSubstance> {  } },
            { 1.3399999999999999e-11d, new List<RadioactiveSubstance> { new Neon24(), new Thallium207() } },
            { 9.9e-15d, new List<RadioactiveSubstance> { new Fluorine23(), new Lead208() } },

        };
    }
}
    
    