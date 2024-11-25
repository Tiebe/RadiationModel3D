using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead205n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead205n";
        public override double halfLife { get; } = 0.00555d;
        public override double atomicWeight { get; } = 204.97557d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead205() }, { 8.6e-05d, new GammaParticle(26220.0, 0.04729) }, { 0.08900000000000001d, new GammaParticle(284150.0, 0.00436) }, { 0.0074d, new GammaParticle(310350.0, 0.00399) }, { 0.14d, new GammaParticle(703450.0, 0.00176) }, { 0.848d, new GammaParticle(987660.0, 0.00126) }, { 0.0040999999999999995d, new GammaParticle(1013800.0, 0.00122) }, { 0.28955723003692d, new GammaParticle(12522.0, 0.09901) }, { 0.011431213727319296d, new GammaParticle(72805.0, 0.01703) }, { 0.019212123911461d, new GammaParticle(74970.0, 0.01654) }, { 0.00656642949402435d, new GammaParticle(84986.0, 0.01459) }, { 0.008549491201219703d, new GammaParticle(86022.0, 0.01441) }, { 0.001983061707195354d, new GammaParticle(87301.0, 0.0142) } } },

        };
    }
}
    