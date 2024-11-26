using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium211";
        public override double halfLife { get; } = 0.516d;
        public override double atomicWeight { get; } = 210.98665d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead207() }, { 1.0d, new AlphaParticle(8616502.09) }, { 3.21e-05d, new GammaParticle(328200.0, 0.00378) }, { 0.005350000000000001d, new GammaParticle(569650.0, 0.00218) }, { 0.005510500000000001d, new GammaParticle(897800.0, 0.00138) }, { 7.2225e-06d, new GammaParticle(1063656.0, 0.00117) }, { 7.76276655162555e-05d, new GammaParticle(12522.0, 0.09901) }, { 5.615681881030072e-05d, new GammaParticle(72805.0, 0.01703) }, { 9.438120808453902e-05d, new GammaParticle(74970.0, 0.01654) }, { 3.22581486203228e-05d, new GammaParticle(84986.0, 0.01459) }, { 4.200010950366029e-05d, new GammaParticle(86022.0, 0.01441) }, { 9.741960883337486e-06d, new GammaParticle(87301.0, 0.0142) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    