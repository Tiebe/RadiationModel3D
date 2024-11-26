using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium230";
        public override double halfLife { get; } = 2385198692863.5615d;
        public override double atomicWeight { get; } = 230.03313d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium226() }, { 1.0d, new AlphaParticle(5791902.09) }, { 0.0037673d, new GammaParticle(67672.0, 0.01832) }, { 5.959e-07d, new GammaParticle(110000.0, 0.01127) }, { 2.828e-09d, new GammaParticle(124800.0, 0.00993) }, { 0.00048783d, new GammaParticle(143872.0, 0.00862) }, { 8.787e-05d, new GammaParticle(186053.0, 0.00666) }, { 5.151e-08d, new GammaParticle(205100.0, 0.00605) }, { 8.382999999999999e-08d, new GammaParticle(235000.0, 0.00528) }, { 0.0001111d, new GammaParticle(253729.0, 0.00489) }, { 8.484e-06d, new GammaParticle(253800.0, 0.00489) }, { 5.454e-09d, new GammaParticle(551800.0, 0.00225) }, { 3.333e-08d, new GammaParticle(570500.0, 0.00217) }, { 7.979e-09d, new GammaParticle(620000.0, 0.002) }, { 0.07731809660327399d, new GammaParticle(14920.0, 0.0831) }, { 4.258131912065503e-05d, new GammaParticle(85432.0, 0.01451) }, { 6.955458856689812e-05d, new GammaParticle(88471.0, 0.01401) }, { 2.440307027236661e-05d, new GammaParticle(100119.0, 0.01238) }, { 3.240727732170286e-05d, new GammaParticle(101370.0, 0.01223) }, { 8.004207049336248e-06d, new GammaParticle(102948.0, 0.01204) } } },
            { 5.8e-13d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 4e-14d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    