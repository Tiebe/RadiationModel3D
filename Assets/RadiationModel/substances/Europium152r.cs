using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium152r : RadioactiveSubstance
    {
        public override string name { get; } = "Europium152r";
        public override double halfLife { get; } = 5760.0d;
        public override double atomicWeight { get; } = 151.92191d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium152() }, { 0.0028577000000000003d, new GammaParticle(12598.0, 0.09842) }, { 0.012546d, new GammaParticle(18210.0, 0.06809) }, { 0.000134d, new GammaParticle(39750.0, 0.03119) }, { 0.0068306d, new GammaParticle(77230.0, 0.01605) }, { 0.6970000000000001d, new GammaParticle(89849.0, 0.0138) }, { 0.257519354347248d, new GammaParticle(6603.0, 0.18777) }, { 0.06440053902952678d, new GammaParticle(40901.0, 0.03031) }, { 0.11620450925573218d, new GammaParticle(41541.0, 0.02985) }, { 0.036609131409174114d, new GammaParticle(47146.0, 0.0263) }, { 0.046054287312741034d, new GammaParticle(47645.0, 0.02602) }, { 0.009445155903566921d, new GammaParticle(48248.0, 0.0257) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    