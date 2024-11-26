using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton95m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton95m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 94.93992d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton95() }, { 0.32095d, new GammaParticle(81700.0, 0.01518) }, { 0.917d, new GammaParticle(113800.0, 0.01089) }, { 0.01677502189475d, new GammaParticle(1648.0, 0.75233) }, { 0.11316086137035518d, new GammaParticle(12596.0, 0.09843) }, { 0.21820451479050362d, new GammaParticle(12649.0, 0.09802) }, { 0.05228757797887098d, new GammaParticle(14169.0, 0.0875) }, { 0.057558165839141175d, new GammaParticle(14209.0, 0.08726) }, { 0.005270587860270195d, new GammaParticle(14313.0, 0.08662) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    