using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium159";
        public override double halfLife { get; } = 12476160.0d;
        public override double atomicWeight { get; } = 158.92575d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium159() }, { 0.0227d, new GammaParticle(58000.0, 0.02138) }, { 4.6e-06d, new GammaParticle(79400.0, 0.01562) }, { 1.1e-06d, new GammaParticle(137500.0, 0.00902) }, { 4.0000000000000003e-07d, new GammaParticle(210800.0, 0.00588) }, { 3.6e-08d, new GammaParticle(226000.0, 0.00549) }, { 1.37e-06d, new GammaParticle(290200.0, 0.00427) }, { 1.08e-08d, new GammaParticle(305500.0, 0.00406) }, { 9.5e-06d, new GammaParticle(348100.0, 0.00356) }, { 5.5e-07d, new GammaParticle(363500.0, 0.00341) }, { 0.1924438129927515d, new GammaParticle(7118.0, 0.17418) }, { 0.26637344768973525d, new GammaParticle(43743.0, 0.02834) }, { 0.47762855960146183d, new GammaParticle(44481.0, 0.02787) }, { 0.1525233662286402d, new GammaParticle(50494.0, 0.02455) }, { 0.192026918081858d, new GammaParticle(51040.0, 0.02429) }, { 0.039503551853217814d, new GammaParticle(51699.0, 0.02398) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    