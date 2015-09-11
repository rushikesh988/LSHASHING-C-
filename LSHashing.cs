using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSHashing
{
    class LSHashing
    {
        
//To generate random hyperplanes use external tool with normal distrubution support. or use k means for hyperplanes for more suffisticated approach
        static double[,] random_hyperplanes ={
                                            {-6.94798122314663,7.07170472522133,4.19837118999886,10.5096145500822,10.6612527611406,0.177111152585722,-1.42267366212213,-22.6806712289111,-0.239852534186841,-5.42253104003489,-0.979368233085625,-2.17806522322407,0.119507481792609,14.5762452946851,8.3592712417049,10.2067011816403,7.97581559368302,0.858555126454217,0.0919445510913428,12.2606381104512,-4.71147666909549,6.61810019784687,-9.39408421785696,6.04420437126968,-4.08454563410021,5.75454500872392,2.32545841410336,-2.58244976208115,-5.97395159929295,-1.4240521271118,11.8342196825454,-3.57842214920057,-4.59630296606506,11.766707705874,-3.29401775373466,-7.91295897740404,-3.10139868163699,3.74189219253726,8.04038672708199,10.0638635631409,0.129506882544554,21.5456499422037,6.05560757233682,-0.324759016710343,-0.631396885741356,-1.78233230807817,-12.8113358287572,7.54705235311481,-9.06907421284768,-5.08791095025495,10.9082879553282,-3.44468618089371,17.2794866020171,-5.0262875205786,2.9683074912228,-4.75375271688577,6.42913331803764,18.2715815583076,8.09158929880194,0.420279617860405,-8.96972995017689,5.1292685520693,0.102720986719203,-11.3784291567185,18.146627674424,-10.3254313607734,-4.96508087421566,-9.13464449271884,20.3636538949212,4.38145489235018,7.60844526209043,8.43261481516658,-10.828380599881,2.51174380382373,5.4436099836566,1.79661967866982,-5.35267411296231,14.303621723155,6.59808828776823,12.7610038409983,-1.09277815170066,-0.240130296586555,-4.46798506464939,-2.50795350770707,6.11076563673833,-19.6071674713521,6.42483855841792,2.20222808185451,0.773249421640664,-10.0783157128858,10.4031810193382,-13.4733345806154,1.60552933832442,4.79794770160083,-28.0396267019643,-4.10332209568842,-6.87455057993494,4.16141236677464,9.57207079562762,-8.5401796559789,-3.05675387284307,-5.72380783374794,17.2091555986409,4.24792594644623,3.34389616972247,5.44962339167265,14.7514867552621,2.77556453556483,-7.16474789531736,-4.68398818157715,-25.7413061323493,-12.9271301281889,-11.024951468286,6.64755682220798,3.79291493642468,-4.10014903949703,-0.052703069756124,-4.84495723898924,5.78949345102854,-15.948234648634,7.2743411515451,-6.97877994846369,-9.30124400887036,17.8896551326258,-18.4884808523134,-3.93205989819133,-4.30223457587949,-8.82528223070645,8.95775432001885,-14.3738150920956,-1.75478687225824,-9.4442172512644,1.82050314969025,-17.5902341361563,-2.79823628378756,-8.80974863633533,6.99334198579287,-3.40491597000516,10.2417963198073,-3.62185683221134,2.43938197266825,-2.16238721881295,7.88637379428293,9.10767971929551},
                                            {-24.3998404037556,-5.76924913265055,-0.00722863902580075,-6.92472479363048,1.68879113003198,-3.97759943043085,-9.5589923615396,-8.62914733090216,8.76952845619721,20.4756155598943,9.32683824078372,-4.48656356815921,-15.965508271687,1.20780411349694,21.2214019919214,-4.5094020775985,-23.0465691180164,-6.3938390410869,-1.14835472693023,-4.41629127222512,2.52032398659873,-3.20968281513486,16.5502442132641,4.67292315002245,-4.05622705054822,21.1788671137735,-7.60234533345639,-0.167670166030534,0.333968319030098,-0.717125090976139,2.87289674719247,-5.23112438641981,3.78818263868132,-16.0528888196858,22.4677125724078,21.7495034007002,-6.82469581773019,7.12237152300388,-8.23922995098265,4.11140394003895,10.3042205277155,8.89345000664444,-1.74588765075112,3.51992173554605,13.6238046094172,11.2945934433883,-3.96104814663265,-6.19057341914392,0.208015788427687,2.09146972271636,-7.42915686255935,-5.06116646030038,11.7095362124652,-5.85850358131546,2.46815111637229,8.01518190103732,-10.808407908162,4.46740261921691,9.69004980098918,-3.33258707597795,13.8972413628615,2.39740776357746,-7.22029622586688,-1.9190901428673,0.704388936934447,-17.4050874562011,-3.50920082194712,13.9012435059874,6.91990555576529,-2.30198289864878,-6.58564188932076,6.22952629202166,-19.7670191604775,-1.47136557666942,17.1632713382313,15.4614810319704,16.2007892742844,21.3552784046932,-4.84696284605561,-5.23703106133098,6.48959483500083,-2.74478023770179,24.5053883779057,0.525633545427621,11.1780324820382,-4.82246063035736,4.39686637872305,2.54066876095172,0.711662781796135,-0.334493294347252,-14.1323522698904,5.51722895052975,10.1809147120544,-19.9019323866818,-19.1241989845263,-9.27791125022265,-1.98004196979544,1.9442704747898,6.40245644020719,-1.00235420390605,-15.0967550671995,-10.4082319826764,6.54551012262293,-6.81426659090437,-10.3314502066642,-5.53241208797234,-19.5688402388593,9.1849440480758,-2.21556638814388,5.71080889558647,4.41921486594717,0.48682989412704,-24.6337347266541,-16.9473304328886,-16.8587373937463,11.1416564448935,-1.51595667698755,4.5301573946973,7.35264091573981,7.57014295139794,-4.27329201872164,-11.6744824938745,-12.8655735683092,-2.43639530794242,7.4970147685859,16.9077339999349,11.6350542563321,8.86354556879106,11.3638022578431,14.0334162513545,-13.3416542935228,8.06407591686204,-4.23566401306718,12.7305143019348,9.55772633287127,-13.7956759404289,-11.3825211636185,-12.9432727180446,-13.1498141861807,-3.66185615921401,-10.4556596762835,-10.9687545533896,-3.41675570398906,-3.72311357667538},
                                            }; //two rows results in 2^n hashes  add more for incresing length
                                            //No of cols in this matrix decides the no of dimentions in data also rows dicides the signature lenght


        static void Main(string[] args)
        {
         double[] FV = { -6.94798122314663, 7.07170472522133, 4.19837118999886, 10.5096145500822, 10.6612527611406, 0.177111152585722, -1.42267366212213, -22.6806712289111, -0.239852534186841, -5.42253104003489, -0.979368233085625, -2.17806522322407, 0.119507481792609, 14.5762452946851, 8.3592712417049, 10.2067011816403, 7.97581559368302, 0.858555126454217, 0.0919445510913428, 12.2606381104512, -4.71147666909549, 6.61810019784687, -9.39408421785696, 6.04420437126968, -4.08454563410021, 5.75454500872392, 2.32545841410336, -2.58244976208115, -5.97395159929295, -1.4240521271118, 11.8342196825454, -3.57842214920057, -4.59630296606506, 11.766707705874, -3.29401775373466, -7.91295897740404, -3.10139868163699, 3.74189219253726, 8.04038672708199, 10.0638635631409, 0.129506882544554, 21.5456499422037, 6.05560757233682, -0.324759016710343, -0.631396885741356, -1.78233230807817, -12.8113358287572, 7.54705235311481, -9.06907421284768, -5.08791095025495, 10.9082879553282, -3.44468618089371, 17.2794866020171, -5.0262875205786, 2.9683074912228, -4.75375271688577, 6.42913331803764, 18.2715815583076, 8.09158929880194, 0.420279617860405, -8.96972995017689, 5.1292685520693, 0.102720986719203, -11.3784291567185, 18.146627674424, -10.3254313607734, -4.96508087421566, -9.13464449271884, 20.3636538949212, 4.38145489235018, 7.60844526209043, 8.43261481516658, -10.828380599881, 2.51174380382373, 5.4436099836566, 1.79661967866982, -5.35267411296231, 14.303621723155, 6.59808828776823, 12.7610038409983, -1.09277815170066, -0.240130296586555, -4.46798506464939, -2.50795350770707, 6.11076563673833, -19.6071674713521, 6.42483855841792, 2.20222808185451, 0.773249421640664, -10.0783157128858, 10.4031810193382, -13.4733345806154, 1.60552933832442, 4.79794770160083, -28.0396267019643, -4.10332209568842, -6.87455057993494, 4.16141236677464, 9.57207079562762, -8.5401796559789, -3.05675387284307, -5.72380783374794, 17.2091555986409, 4.24792594644623, 3.34389616972247, 5.44962339167265, 14.7514867552621, 2.77556453556483, -7.16474789531736, -4.68398818157715, -25.7413061323493, -12.9271301281889, -11.024951468286, 6.64755682220798, 3.79291493642468, -4.10014903949703, -0.052703069756124, -4.84495723898924, 5.78949345102854, -15.948234648634, 7.2743411515451, -6.97877994846369, -9.30124400887036, 17.8896551326258, -18.4884808523134, -3.93205989819133, -4.30223457587949, -8.82528223070645, 8.95775432001885, -14.3738150920956, -1.75478687225824, -9.4442172512644, 1.82050314969025, -17.5902341361563, -2.79823628378756, -8.80974863633533, 6.99334198579287, -3.40491597000516, 10.2417963198073, -3.62185683221134, 2.43938197266825, -2.16238721881295, 7.88637379428293, 9.10767971929551 };

        int hash = calculateHash(FV);// FV should be of equal length of no of cols in random hyperplanes.

        }




        public static int calculateHash(double[] FV)
        {
         
               double[] dotproduct_results=DotProduct(FV);
           int[] a =returnSignatureBinary(dotproduct_results);

            int signature = binary2int(a);
            Console.WriteLine(signature);
            return signature;
        }

        private static int binary2int(int[] a)
        {
            string binarystring = "";
            for (int i = 0; i < a.Length; i++)
            {
                binarystring = binarystring + a[i].ToString();
            }
            int signature =Convert.ToInt32(binarystring, 2);
            return signature;
        }


        private static int[] returnSignatureBinary(double[] dotproduct_results)
        {
            int[] a = new int[dotproduct_results.Length];
            for (int i = 0; i < dotproduct_results.Length; i++)
            {
                if (dotproduct_results[i] > 0)
                {
                    a[i] = 0;
                }
                else {
                    a[i] = 1;
                }
            }
            return a;
        }


        private static double[] DotProduct(double[] vec1)
        {
            double[] dotproduct_results = new double[random_hyperplanes.GetLength(0)];
            for (int i = 0; i < random_hyperplanes.GetLength(0); i++)
            {
                if (vec1 == null)
                    return null;
                                
                double tVal = 0;
                for (int x = 0; x < vec1.Length; x++)
                {
                    tVal += vec1[x] * random_hyperplanes[i,x];
                }

                dotproduct_results[i]=tVal;
            }



            return dotproduct_results;
        }

    }
}
