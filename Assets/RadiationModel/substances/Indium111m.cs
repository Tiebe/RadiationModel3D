using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium111m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium111m";
        public override double halfLife { get; } = 462.0d;
        public override double atomicWeight { get; } = 110.90568d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium111() }, { 0.87d, new GammaParticle(537000.0, 0.00231) }, { 0.0081065130048d, new GammaParticle(3571.0, 0.3472) }, { 0.02587255476897d, new GammaParticle(24001.0, 0.05166) }, { 0.04854137855341463d, new GammaParticle(24209.0, 0.05121) }, { 0.013619625779508718d, new GammaParticle(27367.0, 0.0453) }, { 0.016207354677615374d, new GammaParticle(27581.0, 0.04495) }, { 0.002587728898106656d, new GammaParticle(27858.0, 0.04451) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    