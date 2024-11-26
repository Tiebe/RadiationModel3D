using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon134m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon134m";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 133.9075d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon134() }, { 0.7d, new GammaParticle(234300.0, 0.00529) }, { 1.0d, new GammaParticle(847025.0, 0.00146) }, { 1.0d, new GammaParticle(884090.0, 0.0014) }, { 0.025519759099999997d, new GammaParticle(4540.0, 0.27309) }, { 0.051176519085976126d, new GammaParticle(29458.0, 0.04209) }, { 0.09480644513889612d, new GammaParticle(29778.0, 0.04164) }, { 0.0274840095268024d, new GammaParticle(33726.0, 0.03676) }, { 0.03397023577512777d, new GammaParticle(34030.0, 0.03643) }, { 0.006486226248325367d, new GammaParticle(34414.0, 0.03603) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    