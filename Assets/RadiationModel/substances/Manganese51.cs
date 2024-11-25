using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese51 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese51";
        public override double halfLife { get; } = 2772.0d;
        public override double atomicWeight { get; } = 50.94821d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium51() }, { 1.0d, new BetaParticle(1, 1979955.0) }, { 0.0001537d, new GammaParticle(603800.0, 0.00205) }, { 0.00265d, new GammaParticle(749070.0, 0.00166) }, { 0.0001484d, new GammaParticle(808190.0, 0.00153) }, { 0.0007817499999999999d, new GammaParticle(1148000.0, 0.00108) }, { 0.00075525d, new GammaParticle(1164400.0, 0.00106) }, { 7.950000000000001e-05d, new GammaParticle(1353900.0, 0.00092) }, { 3.9750000000000004e-05d, new GammaParticle(1557500.0, 0.0008) }, { 6.36e-05d, new GammaParticle(1899410.0, 0.00065) }, { 0.000371d, new GammaParticle(2001350.0, 0.00062) }, { 6.890000000000001e-05d, new GammaParticle(2079620.0, 0.0006) }, { 0.00012985d, new GammaParticle(2312520.0, 0.00054) }, { 1.9417800600000001d, new GammaParticle(511000.0, 0.00243) }, { 0.00018858602550819565d, new GammaParticle(597.0, 2.07679) }, { 0.0022337032979177847d, new GammaParticle(5406.0, 0.22935) }, { 0.004387553128889775d, new GammaParticle(5415.0, 0.22896) }, { 0.0008912211150482977d, new GammaParticle(5966.0, 0.20782) }, { 0.0008912211150482977d, new GammaParticle(5966.0, 0.20782) } } },

        };
    }
}
    