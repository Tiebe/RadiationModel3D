using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium94m";
        public override double halfLife { get; } = 375.78d;
        public override double atomicWeight { get; } = 93.90732d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium94() }, { 0.000731d, new GammaParticle(40940.0, 0.03028) }, { 0.0304887596976d, new GammaParticle(2299.0, 0.5393) }, { 0.11206433467415707d, new GammaParticle(16521.0, 0.07505) }, { 0.21402661320503644d, new GammaParticle(16615.0, 0.07462) }, { 0.05537874967026652d, new GammaParticle(18694.0, 0.06632) }, { 0.0636855621208065d, new GammaParticle(18795.0, 0.06597) }, { 0.008306812450539977d, new GammaParticle(18951.0, 0.06542) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum94() }, { 1.0d, new BetaParticle(-1, 1042940.0) }, { 3.1e-05d, new GammaParticle(702000.0, 0.00177) }, { 0.005d, new GammaParticle(871000.0, 0.00142) }, { 7.5e-06d, new GammaParticle(993000.0, 0.00125) }, { 2.07627469809e-07d, new GammaParticle(2440.0, 0.50813) }, { 1.0471596252141349e-06d, new GammaParticle(17374.0, 0.07136) }, { 1.9957301795580995e-06d, new GammaParticle(17479.0, 0.07093) }, { 5.236723702147018e-07d, new GammaParticle(19681.0, 0.063) }, { 6.043179152277657e-07d, new GammaParticle(19794.0, 0.06264) }, { 8.064554501306408e-08d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    